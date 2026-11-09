# Fact 06f8f6de

Store id: 79edeeee-7e08-42bd-adbd-469c4878410d

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
- posted_at: `2026-11-09T23:32:02.2306770+00:00`

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
  "id": "79edeeee-7e08-42bd-adbd-469c4878410d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2306770+00:00"
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
  "subject_id": "fe392f89-8e15-4c2c-bb95-3ef1283ea70f",
  "subject_name": "django/db/models/functions/text::Ord.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
