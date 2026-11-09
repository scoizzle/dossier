# Fact 1fac2566

Store id: df92b605-61ca-460b-bf96-eef418d970a2

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
- posted_at: `2026-11-09T23:44:54.0658820+00:00`

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
  "id": "df92b605-61ca-460b-bf96-eef418d970a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0658820+00:00"
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
  "subject_id": "327d6afd-74d5-4e1a-9198-321c3823f064",
  "subject_name": "django/db/models/functions/text::ConcatPair.pipes_concat_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def pipes_concat_sql(self, compiler, connection, **extra_context)"
}
```
