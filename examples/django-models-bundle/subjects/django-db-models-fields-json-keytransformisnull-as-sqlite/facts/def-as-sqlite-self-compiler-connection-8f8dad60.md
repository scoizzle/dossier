# Fact 8f8dad60

Store id: 4a9ad86d-0fc8-429c-84c4-e12113da6863

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
- posted_at: `2026-11-09T23:31:57.9950890+00:00`

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
  "id": "4a9ad86d-0fc8-429c-84c4-e12113da6863",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9950890+00:00"
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
  "subject_id": "8096b6de-76a7-483a-b464-13e0be238af8",
  "subject_name": "django/db/models/fields/json::KeyTransformIsNull.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection)"
}
```
