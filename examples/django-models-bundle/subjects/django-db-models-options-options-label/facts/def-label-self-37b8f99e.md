# Fact 37b8f99e

Store id: b7b432d9-f84c-4ed5-aee4-02b5ee7885e1

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
- posted_at: `2026-11-09T23:32:03.8932360+00:00`

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
  "id": "b7b432d9-f84c-4ed5-aee4-02b5ee7885e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8932360+00:00"
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
  "subject_id": "14385c1f-3613-494c-b39c-bdf128c5910c",
  "subject_name": "django/db/models/options::Options.label",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label(self)"
}
```
