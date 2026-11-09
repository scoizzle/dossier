# Fact 2497b8f8

Store id: ae431999-8aca-4c83-89a8-a8aaa51f10ef

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
- posted_at: `2026-11-09T23:44:54.0702800+00:00`

## Data

```json
{
  "end_line": 110,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 102,
  "symbol": "ConcatPair.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":102,"selector":"L102-L110","symbol":"ConcatPair.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 110,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 102,
    "symbol": "ConcatPair.as_mysql"
  },
  "id": "ae431999-8aca-4c83-89a8-a8aaa51f10ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0702800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 102,
        "selector": "L102-L110",
        "symbol": "ConcatPair.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "4c42d918-48ad-408d-84d8-ab5d19482e9d",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
