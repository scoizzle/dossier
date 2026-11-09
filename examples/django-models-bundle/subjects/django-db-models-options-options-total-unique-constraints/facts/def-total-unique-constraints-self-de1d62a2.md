# Fact de1d62a2

Store id: d919954c-38f5-4a2a-9ee5-61a423bd8bf4

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
- posted_at: `2026-11-09T23:32:04.0382120+00:00`

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
  "id": "d919954c-38f5-4a2a-9ee5-61a423bd8bf4",
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
    "posted_at": "2026-11-09T23:32:04.0382120+00:00"
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
  "subject_id": "f43762bd-7623-4bf5-85c6-c653dbefa356",
  "subject_name": "django/db/models/options::Options.total_unique_constraints",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def total_unique_constraints(self)"
}
```
