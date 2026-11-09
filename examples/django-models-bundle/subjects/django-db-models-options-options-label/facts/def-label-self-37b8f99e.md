# Fact 37b8f99e

Store id: fb82c99b-8696-41d6-a779-85185123851e

## Text

```text
def label(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.7493190+00:00`

## Data

```json
{
  "end_line": 174,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 172,
  "symbol": "Options.label"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":172,"selector":"L172-L174","symbol":"Options.label"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.label](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 174,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 172,
    "symbol": "Options.label"
  },
  "id": "fb82c99b-8696-41d6-a779-85185123851e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7493190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 172,
        "selector": "L172-L174",
        "symbol": "Options.label"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "d46517de-22bd-4c00-8a0e-85372e13653c",
  "subject_name": "django/db/models/options::Options.label",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label(self)"
}
```
