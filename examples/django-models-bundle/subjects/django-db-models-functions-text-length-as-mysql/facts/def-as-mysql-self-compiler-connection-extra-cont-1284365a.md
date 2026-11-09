# Fact 1284365a

Store id: e9cc39e9-19a5-449e-90e4-e1cac68aa5d1

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
- posted_at: `2026-11-09T23:32:02.2026350+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "method",
  "parent": "Length",
  "start_line": 186,
  "symbol": "Length.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L189","symbol":"Length.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Length.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "method",
    "parent": "Length",
    "start_line": 186,
    "symbol": "Length.as_mysql"
  },
  "id": "e9cc39e9-19a5-449e-90e4-e1cac68aa5d1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.2026350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L189",
        "symbol": "Length.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "0d6ab6d9-95f3-4fb7-99e0-3c6424ecbb05",
  "subject_name": "django/db/models/functions/text::Length.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
