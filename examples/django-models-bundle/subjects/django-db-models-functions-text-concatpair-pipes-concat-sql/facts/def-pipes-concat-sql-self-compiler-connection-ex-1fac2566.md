# Fact 1fac2566

Store id: a7e13b1d-5946-41d8-b5ed-aa0b48eff119

## Text

```text
def pipes_concat_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:02.1657950+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 76,
  "symbol": "ConcatPair.pipes_concat_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":76,"selector":"L76-L84","symbol":"ConcatPair.pipes_concat_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.pipes_concat_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 76,
    "symbol": "ConcatPair.pipes_concat_sql"
  },
  "id": "a7e13b1d-5946-41d8-b5ed-aa0b48eff119",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1657950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 76,
        "selector": "L76-L84",
        "symbol": "ConcatPair.pipes_concat_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "572e2239-cfed-4267-805d-c219fb0e5b16",
  "subject_name": "django/db/models/functions/text::ConcatPair.pipes_concat_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def pipes_concat_sql(self, compiler, connection, **extra_context)"
}
```
