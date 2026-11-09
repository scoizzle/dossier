# Fact 1e2afdf5

Store id: 2db9b72c-45bb-4215-9a66-1e46e6eb9cd7

## Text

```text
def fields_map(self)
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
- posted_at: `2026-11-09T22:39:48.8650990+00:00`

## Data

```json
{
  "end_line": 668,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 655,
  "symbol": "Options.fields_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":655,"selector":"L655-L668","symbol":"Options.fields_map"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.fields_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 668,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 655,
    "symbol": "Options.fields_map"
  },
  "id": "2db9b72c-45bb-4215-9a66-1e46e6eb9cd7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8650990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 655,
        "selector": "L655-L668",
        "symbol": "Options.fields_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "9f917f01-8e52-4d5f-abc6-c7883653d8ea",
  "subject_name": "django/db/models/options::Options.fields_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields_map(self)"
}
```
