# Fact 356eecd2

Store id: f5e29deb-c2b0-421e-8f0b-e4e9053d5f7f

## Text

```text
def db_type(self, connection)
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
- posted_at: `2026-11-09T22:39:44.5159060+00:00`

## Data

```json
{
  "end_line": 2209,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 2206,
  "symbol": "ManyToManyField.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2206,"selector":"L2206-L2209","symbol":"ManyToManyField.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2209,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 2206,
    "symbol": "ManyToManyField.db_type"
  },
  "id": "f5e29deb-c2b0-421e-8f0b-e4e9053d5f7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5159060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2206,
        "selector": "L2206-L2209",
        "symbol": "ManyToManyField.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "35542629-a68e-4485-8c66-09ba04767f47",
  "subject_name": "django/db/models/fields/related::ManyToManyField.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
