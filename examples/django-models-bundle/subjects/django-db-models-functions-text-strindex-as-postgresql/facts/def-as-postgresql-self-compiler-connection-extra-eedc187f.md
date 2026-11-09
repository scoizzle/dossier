# Fact eedc187f

Store id: 86e28555-c558-4e7b-92a0-7f44d5ed3b2e

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:54.1605220+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "StrIndex",
  "start_line": 341,
  "symbol": "StrIndex.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":341,"selector":"L341-L342","symbol":"StrIndex.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::StrIndex.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "StrIndex",
    "start_line": 341,
    "symbol": "StrIndex.as_postgresql"
  },
  "id": "86e28555-c558-4e7b-92a0-7f44d5ed3b2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1605220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 341,
        "selector": "L341-L342",
        "symbol": "StrIndex.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "714e0b76-1357-417e-8624-f7b4f71fd692",
  "subject_name": "django/db/models/functions/text::StrIndex.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
