# Fact 84f9dfbd

Store id: 4023afe6-9a62-464e-93c0-c4ad16205c43

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T22:39:44.4014180+00:00`

## Data

```json
{
  "end_line": 1286,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1285,
  "symbol": "ForeignKey.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1285,"selector":"L1285-L1286","symbol":"ForeignKey.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1286,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1285,
    "symbol": "ForeignKey.get_db_prep_value"
  },
  "id": "4023afe6-9a62-464e-93c0-c4ad16205c43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.4014180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1285,
        "selector": "L1285-L1286",
        "symbol": "ForeignKey.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9fd082b4-4ee5-429d-97c6-51515dba1430",
  "subject_name": "django/db/models/fields/related::ForeignKey.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
