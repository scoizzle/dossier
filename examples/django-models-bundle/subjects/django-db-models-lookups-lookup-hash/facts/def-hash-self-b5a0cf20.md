# Fact b5a0cf20

Store id: d21cadad-bcbc-4256-a3be-f20ea5b5dccc

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T22:39:48.0377880+00:00`

## Data

```json
{
  "end_line": 182,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 181,
  "symbol": "Lookup.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":181,"selector":"L181-L182","symbol":"Lookup.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 182,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 181,
    "symbol": "Lookup.__hash__"
  },
  "id": "d21cadad-bcbc-4256-a3be-f20ea5b5dccc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0377880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 181,
        "selector": "L181-L182",
        "symbol": "Lookup.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "a475be37-1827-4514-b4e5-dfb9ababdabb",
  "subject_name": "django/db/models/lookups::Lookup.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
