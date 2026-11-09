# Fact 948e9523

Store id: 963ef325-1d61-4008-aa79-96d066fc8dae

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
- posted_at: `2026-11-09T23:32:03.9638910+00:00`

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
  "id": "963ef325-1d61-4008-aa79-96d066fc8dae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9638910+00:00"
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
  "subject_id": "e8bb294a-6686-449f-a5b6-4dccd6bcad62",
  "subject_name": "django/db/models/options::Options.base_manager",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def base_manager(self)"
}
```
