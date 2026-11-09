# Fact f642c712

Store id: cd30e07f-653a-40bc-a343-89d9243e442f

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
- posted_at: `2026-11-09T23:31:57.9725070+00:00`

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
  "id": "cd30e07f-653a-40bc-a343-89d9243e442f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9725070+00:00"
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
  "subject_id": "4cedc6f2-8fdb-47a7-a005-676a7c6247b7",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection)"
}
```
