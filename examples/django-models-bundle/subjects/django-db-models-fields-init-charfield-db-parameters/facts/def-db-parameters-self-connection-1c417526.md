# Fact 1c417526

Store id: f5fd8153-0fb9-48b2-81a0-da1f98eec660

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T22:39:42.3818680+00:00`

## Data

```json
{
  "end_line": 1328,
  "entity_kind": "method",
  "parent": "CharField",
  "start_line": 1325,
  "symbol": "CharField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1325,"selector":"L1325-L1328","symbol":"CharField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::CharField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1328,
    "entity_kind": "method",
    "parent": "CharField",
    "start_line": 1325,
    "symbol": "CharField.db_parameters"
  },
  "id": "f5fd8153-0fb9-48b2-81a0-da1f98eec660",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3818680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1325,
        "selector": "L1325-L1328",
        "symbol": "CharField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "de29908e-338e-42ef-94ed-bd03c136556f",
  "subject_name": "django/db/models/fields/__init__::CharField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
