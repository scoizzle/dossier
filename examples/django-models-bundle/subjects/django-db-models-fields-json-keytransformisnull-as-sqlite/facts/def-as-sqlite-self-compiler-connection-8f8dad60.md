# Fact 8f8dad60

Store id: dd49cee0-2dd8-4ba0-a523-3357d38222c5

## Text

```text
def as_sqlite(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:51.0392620+00:00`

## Data

```json
{
  "end_line": 615,
  "entity_kind": "method",
  "parent": "KeyTransformIsNull",
  "start_line": 607,
  "symbol": "KeyTransformIsNull.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":607,"selector":"L607-L615","symbol":"KeyTransformIsNull.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIsNull.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 615,
    "entity_kind": "method",
    "parent": "KeyTransformIsNull",
    "start_line": 607,
    "symbol": "KeyTransformIsNull.as_sqlite"
  },
  "id": "dd49cee0-2dd8-4ba0-a523-3357d38222c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0392620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 607,
        "selector": "L607-L615",
        "symbol": "KeyTransformIsNull.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "e2a80821-61af-4486-a966-d3bed73e5fc3",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
