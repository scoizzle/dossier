# Fact 1e2afdf5

Store id: a05f6120-f8e2-4fa9-9fea-ba26e5f4eefe

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
- posted_at: `2026-11-09T23:32:03.9985030+00:00`

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
  "id": "a05f6120-f8e2-4fa9-9fea-ba26e5f4eefe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9985030+00:00"
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
  "subject_id": "698d79d4-80da-4f3b-8e20-da127b64eb3a",
  "subject_name": "django/db/models/options::Options.fields_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields_map(self)"
}
```
