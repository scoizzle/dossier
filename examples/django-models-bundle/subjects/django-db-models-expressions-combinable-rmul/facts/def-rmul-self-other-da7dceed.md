# Fact da7dceed

Store id: 0b9eec2c-c931-4ee1-92bd-553f6b29e7b6

## Text

```text
def __rmul__(self, other)
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
- posted_at: `2026-11-09T22:39:41.4865190+00:00`

## Data

```json
{
  "end_line": 140,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 139,
  "symbol": "Combinable.__rmul__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":139,"selector":"L139-L140","symbol":"Combinable.__rmul__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rmul__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 140,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 139,
    "symbol": "Combinable.__rmul__"
  },
  "id": "0b9eec2c-c931-4ee1-92bd-553f6b29e7b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4865190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 139,
        "selector": "L139-L140",
        "symbol": "Combinable.__rmul__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f2835b39-d6d7-46af-b000-b43dfb35ecc1",
  "subject_name": "django/db/models/expressions::Combinable.__rmul__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rmul__(self, other)"
}
```
