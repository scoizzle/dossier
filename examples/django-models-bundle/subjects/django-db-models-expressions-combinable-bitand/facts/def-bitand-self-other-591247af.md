# Fact 591247af

Store id: 6a93a675-ca0e-41e5-b7a1-1f4eba1bd439

## Text

```text
def bitand(self, other)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.4777370+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 104,
  "symbol": "Combinable.bitand"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":104,"selector":"L104-L105","symbol":"Combinable.bitand"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitand](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 104,
    "symbol": "Combinable.bitand"
  },
  "id": "6a93a675-ca0e-41e5-b7a1-1f4eba1bd439",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4777370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 104,
        "selector": "L104-L105",
        "symbol": "Combinable.bitand"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "829a7c27-5cf1-4a6c-95ca-b7eb9eb646de",
  "subject_name": "django/db/models/expressions::Combinable.bitand",
  "tags": [
    "entity:method"
  ],
  "text": "def bitand(self, other)"
}
```
