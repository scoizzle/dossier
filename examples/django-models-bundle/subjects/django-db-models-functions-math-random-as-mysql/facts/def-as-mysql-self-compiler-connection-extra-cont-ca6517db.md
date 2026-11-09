# Fact ca6517db

Store id: 84933909-52fe-4e59-9204-f47d69a055ab

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:46.6531640+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "Random",
  "start_line": 163,
  "symbol": "Random.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":163,"selector":"L163-L164","symbol":"Random.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Random.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "Random",
    "start_line": 163,
    "symbol": "Random.as_mysql"
  },
  "id": "84933909-52fe-4e59-9204-f47d69a055ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6531640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 163,
        "selector": "L163-L164",
        "symbol": "Random.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "002d7861-79c5-40bf-94ef-cbdde4d872f3",
  "subject_name": "django/db/models/functions/math::Random.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
