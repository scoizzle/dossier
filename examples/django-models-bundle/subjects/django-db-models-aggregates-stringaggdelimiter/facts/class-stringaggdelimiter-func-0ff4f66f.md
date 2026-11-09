# Fact 0ff4f66f

Store id: 5db27747-3feb-4682-898c-da99d754a4db

## Text

```text
class StringAggDelimiter(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.5437320+00:00`

## Data

```json
{
  "end_line": 368,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 352,
  "symbol": "StringAggDelimiter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":352,"selector":"L352-L368","symbol":"StringAggDelimiter"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAggDelimiter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 368,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 352,
    "symbol": "StringAggDelimiter"
  },
  "id": "5db27747-3feb-4682-898c-da99d754a4db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5437320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 352,
        "selector": "L352-L368",
        "symbol": "StringAggDelimiter"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "f842e3c3-4488-4483-b399-d11ff740215e",
  "subject_name": "django/db/models/aggregates::StringAggDelimiter",
  "tags": [
    "entity:class"
  ],
  "text": "class StringAggDelimiter(Func)"
}
```
