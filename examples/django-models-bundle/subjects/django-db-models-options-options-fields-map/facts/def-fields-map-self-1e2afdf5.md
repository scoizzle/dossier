# Fact 1e2afdf5

Store id: f0d23f8d-d612-4280-b31b-8b5d823dd586

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
- posted_at: `2026-11-09T23:44:55.5489870+00:00`

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
  "id": "f0d23f8d-d612-4280-b31b-8b5d823dd586",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5489870+00:00"
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
  "subject_id": "969fd7fb-e972-4f9f-95f7-899d6915f0b5",
  "subject_name": "django/db/models/options::Options.fields_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def fields_map(self)"
}
```
