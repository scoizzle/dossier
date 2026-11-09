# Fact 591247af

Store id: 21cfd8bc-dc67-4d2c-825a-37ff3b25d163

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
- posted_at: `2026-11-09T23:31:55.7326890+00:00`

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
  "id": "21cfd8bc-dc67-4d2c-825a-37ff3b25d163",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7326890+00:00"
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
  "subject_id": "dbbc4460-c5ec-45b0-a6c5-9c036921ab83",
  "subject_name": "django/db/models/expressions::Combinable.bitand",
  "tags": [
    "entity:method"
  ],
  "text": "def bitand(self, other)"
}
```
