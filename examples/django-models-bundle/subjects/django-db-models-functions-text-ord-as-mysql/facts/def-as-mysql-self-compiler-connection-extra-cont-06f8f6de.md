# Fact 06f8f6de

Store id: bede2241-d158-4aa3-8207-bb99c63d2087

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
- posted_at: `2026-11-09T22:39:47.1374320+00:00`

## Data

```json
{
  "end_line": 227,
  "entity_kind": "method",
  "parent": "Ord",
  "start_line": 226,
  "symbol": "Ord.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":226,"selector":"L226-L227","symbol":"Ord.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Ord.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 227,
    "entity_kind": "method",
    "parent": "Ord",
    "start_line": 226,
    "symbol": "Ord.as_mysql"
  },
  "id": "bede2241-d158-4aa3-8207-bb99c63d2087",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1374320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 226,
        "selector": "L226-L227",
        "symbol": "Ord.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "dc009801-ae9a-4b97-9fe5-033d5571b461",
  "subject_name": "django/db/models/functions/text::Ord.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
