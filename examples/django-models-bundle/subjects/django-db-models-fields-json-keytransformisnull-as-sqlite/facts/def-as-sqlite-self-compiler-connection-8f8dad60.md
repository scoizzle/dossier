# Fact 8f8dad60

Store id: 2b588a25-c12c-4f2b-881c-8306653250c8

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
- posted_at: `2026-11-09T22:39:43.7287700+00:00`

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
  "id": "2b588a25-c12c-4f2b-881c-8306653250c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7287700+00:00"
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
  "subject_id": "670de3ad-1d47-44a6-a131-6b46a4933cfe",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
