# Fact 1fac2566

Store id: c26872d2-326d-47a9-8f0e-940eb003d102

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
- posted_at: `2026-11-09T22:39:47.0795150+00:00`

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
  "id": "c26872d2-326d-47a9-8f0e-940eb003d102",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0795150+00:00"
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
  "subject_id": "c07241c1-5c3d-4396-bcbb-a3a8394b8ac3",
  "subject_name": "django/db/models/functions/text::ConcatPair.pipes_concat_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def pipes_concat_sql(self, compiler, connection, **extra_context)"
}
```
