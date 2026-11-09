# Fact 9cd3d0e4

Store id: d26db425-7b39-4437-8116-f92b0f74907c

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
- posted_at: `2026-11-09T23:32:00.9572860+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "Cast",
  "start_line": 38,
  "symbol": "Cast.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":38,"selector":"L38-L47","symbol":"Cast.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Cast.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "Cast",
    "start_line": 38,
    "symbol": "Cast.as_mysql"
  },
  "id": "d26db425-7b39-4437-8116-f92b0f74907c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.9572860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 38,
        "selector": "L38-L47",
        "symbol": "Cast.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "1ebd7863-5035-4051-8d46-7a6461cd21c2",
  "subject_name": "django/db/models/functions/comparison::Cast.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
