# Fact de1d62a2

Store id: 74eafe5d-c9c6-4700-8ed1-c81295810fcb

## Text

```text
def total_unique_constraints(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.9589990+00:00`

## Data

```json
{
  "end_line": 990,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 976,
  "symbol": "Options.total_unique_constraints"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":976,"selector":"L976-L990","symbol":"Options.total_unique_constraints"}`

## Items

```json
[
  {
    "text": "Return a list of total unique constraints. Useful for determining set of fields guaranteed to be unique for all rows.",
    "locator": {
      "line": 978
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.total_unique_constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 990,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 976,
    "symbol": "Options.total_unique_constraints"
  },
  "id": "74eafe5d-c9c6-4700-8ed1-c81295810fcb",
  "items": [
    {
      "locator": {
        "line": 978
      },
      "text": "Return a list of total unique constraints. Useful for determining set of fields guaranteed to be unique for all rows."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9589990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 976,
        "selector": "L976-L990",
        "symbol": "Options.total_unique_constraints"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "957ccecb-dbf3-4cb7-a72d-196e4ebafbf9",
  "subject_name": "django/db/models/options::Options.total_unique_constraints",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def total_unique_constraints(self)"
}
```
