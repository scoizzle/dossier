# Fact 948e9523

Store id: 86b945ae-33a0-4f89-b9e6-65f8a4832301

## Text

```text
def base_manager(self)
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
- posted_at: `2026-11-09T22:39:48.8303600+00:00`

## Data

```json
{
  "end_line": 504,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 477,
  "symbol": "Options.base_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":477,"selector":"L477-L504","symbol":"Options.base_manager"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.base_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 504,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 477,
    "symbol": "Options.base_manager"
  },
  "id": "86b945ae-33a0-4f89-b9e6-65f8a4832301",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8303600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 477,
        "selector": "L477-L504",
        "symbol": "Options.base_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "eb392c38-f6a5-468f-a872-1587e9d03db5",
  "subject_name": "django/db/models/options::Options.base_manager",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def base_manager(self)"
}
```
