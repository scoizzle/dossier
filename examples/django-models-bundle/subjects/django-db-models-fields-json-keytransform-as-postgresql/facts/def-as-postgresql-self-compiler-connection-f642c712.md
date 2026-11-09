# Fact f642c712

Store id: 8734a98a-7385-4ae9-a505-5e6e86d2785f

## Text

```text
def as_postgresql(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:43.7123430+00:00`

## Data

```json
{
  "end_line": 533,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 524,
  "symbol": "KeyTransform.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":524,"selector":"L524-L533","symbol":"KeyTransform.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 533,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 524,
    "symbol": "KeyTransform.as_postgresql"
  },
  "id": "8734a98a-7385-4ae9-a505-5e6e86d2785f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7123430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 524,
        "selector": "L524-L533",
        "symbol": "KeyTransform.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c585b911-3ad1-4cd1-a141-2d05adc5cca2",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
