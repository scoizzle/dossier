# Fact d529a804

Store id: 5a8de9a0-4e05-47a5-b67f-59e3b4c46b84

## Text

```text
class Rank(Func)
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
- posted_at: `2026-11-09T23:44:54.5068940+00:00`

## Data

```json
{
  "end_line": 114,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 111,
  "symbol": "Rank"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":111,"selector":"L111-L114","symbol":"Rank"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Rank](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 114,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 111,
    "symbol": "Rank"
  },
  "id": "5a8de9a0-4e05-47a5-b67f-59e3b4c46b84",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.5068940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 111,
        "selector": "L111-L114",
        "symbol": "Rank"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "92f7bdab-38be-4166-abbe-fd30235dfd15",
  "subject_name": "django/db/models/functions/window::Rank",
  "tags": [
    "entity:class"
  ],
  "text": "class Rank(Func)"
}
```
