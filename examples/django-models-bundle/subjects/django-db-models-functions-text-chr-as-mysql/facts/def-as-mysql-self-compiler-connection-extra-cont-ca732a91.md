# Fact ca732a91

Store id: 9e4941b3-02c7-4bb2-a000-0f60bd26ec6e

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
- posted_at: `2026-11-09T23:44:54.0458700+00:00`

## Data

```json
{
  "end_line": 54,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 47,
  "symbol": "Chr.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"selector":"L47-L54","symbol":"Chr.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 54,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 47,
    "symbol": "Chr.as_mysql"
  },
  "id": "9e4941b3-02c7-4bb2-a000-0f60bd26ec6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0458700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 47,
        "selector": "L47-L54",
        "symbol": "Chr.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "89568bd3-ce4c-4092-9a8c-6fe71977bcc4",
  "subject_name": "django/db/models/functions/text::Chr.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
