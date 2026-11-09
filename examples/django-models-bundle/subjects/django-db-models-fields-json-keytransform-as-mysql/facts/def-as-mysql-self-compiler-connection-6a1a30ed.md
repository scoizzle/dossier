# Fact 6a1a30ed

Store id: 2790ef47-051c-4362-b28e-5c56c54e063c

## Text

```text
def as_mysql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9677660+00:00`

## Data

```json
{
  "end_line": 518,
  "entity_kind": "method",
  "parent": "KeyTransform",
  "start_line": 516,
  "symbol": "KeyTransform.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":516,"selector":"L516-L518","symbol":"KeyTransform.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransform.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 518,
    "entity_kind": "method",
    "parent": "KeyTransform",
    "start_line": 516,
    "symbol": "KeyTransform.as_mysql"
  },
  "id": "2790ef47-051c-4362-b28e-5c56c54e063c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9677660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 516,
        "selector": "L516-L518",
        "symbol": "KeyTransform.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "a0a15d66-b448-4e3b-87c6-542b3bfca609",
  "subject_name": "django/db/models/fields/json::KeyTransform.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection)"
}
```
