# Fact 864a7196

Store id: d04bec1c-89ca-4acd-8c13-894118266564

## Text

```text
def db_type_suffix(self, connection)
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
- posted_at: `2026-11-09T23:31:56.4853700+00:00`

## Data

```json
{
  "end_line": 957,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 956,
  "symbol": "Field.db_type_suffix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":956,"selector":"L956-L957","symbol":"Field.db_type_suffix"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_type_suffix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 957,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 956,
    "symbol": "Field.db_type_suffix"
  },
  "id": "d04bec1c-89ca-4acd-8c13-894118266564",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4853700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 956,
        "selector": "L956-L957",
        "symbol": "Field.db_type_suffix"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0e200bed-5bf3-42d1-8232-20925961784d",
  "subject_name": "django/db/models/fields/__init__::Field.db_type_suffix",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_suffix(self, connection)"
}
```
