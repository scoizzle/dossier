# Fact 39ddc7d2

Store id: c5cdcd5b-c11f-4b97-97ff-1353ce56a516

## Text

```text
def app_config(self)
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
- posted_at: `2026-11-09T23:32:03.8997450+00:00`

## Data

```json
{
  "end_line": 183,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 180,
  "symbol": "Options.app_config"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"selector":"L180-L183","symbol":"Options.app_config"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.app_config](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 183,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 180,
    "symbol": "Options.app_config"
  },
  "id": "c5cdcd5b-c11f-4b97-97ff-1353ce56a516",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.8997450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 180,
        "selector": "L180-L183",
        "symbol": "Options.app_config"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "abf36ee6-fae2-4b80-8031-c8eb2a0e81df",
  "subject_name": "django/db/models/options::Options.app_config",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def app_config(self)"
}
```
