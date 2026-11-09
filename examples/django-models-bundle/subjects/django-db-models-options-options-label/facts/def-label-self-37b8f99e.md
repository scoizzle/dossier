# Fact 37b8f99e

Store id: 45c8edc1-e379-40ec-a537-edd3f35c567e

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
- posted_at: `2026-11-09T23:44:55.4599310+00:00`

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
  "id": "45c8edc1-e379-40ec-a537-edd3f35c567e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4599310+00:00"
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
  "subject_id": "a7e20a1c-5f32-4106-a2c8-8b006b03cade",
  "subject_name": "django/db/models/options::Options.label",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label(self)"
}
```
