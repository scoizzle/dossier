# Fact 4a25f99e

Store id: 5291434e-1b8f-455e-ab9b-8d13049d5764

## Text

```text
def create_namedtuple_class(*names)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`, `decorator:functools.lru_cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:45:00.0388450+00:00`

## Data

```json
{
  "end_line": 52,
  "entity_kind": "function",
  "parent": "utils",
  "start_line": 41,
  "symbol": "create_namedtuple_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":41,"selector":"L41-L52","symbol":"create_namedtuple_class"}`

## Referenced by

None.

## Subject

[django/db/models/utils::create_namedtuple_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 52,
    "entity_kind": "function",
    "parent": "utils",
    "start_line": 41,
    "symbol": "create_namedtuple_class"
  },
  "id": "5291434e-1b8f-455e-ab9b-8d13049d5764",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0388450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 41,
        "selector": "L41-L52",
        "symbol": "create_namedtuple_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "e47718ce-5a5c-44af-9819-e7d29ecd40c0",
  "subject_name": "django/db/models/utils::create_namedtuple_class",
  "tags": [
    "entity:function",
    "decorator:functools.lru_cache"
  ],
  "text": "def create_namedtuple_class(*names)"
}
```
