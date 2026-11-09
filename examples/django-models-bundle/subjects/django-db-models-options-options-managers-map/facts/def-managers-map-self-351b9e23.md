# Fact 351b9e23

Store id: 9aa5a2cc-738f-428b-8f63-005ec72948d2

## Text

```text
def managers_map(self)
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
- posted_at: `2026-11-09T22:39:48.8263110+00:00`

## Data

```json
{
  "end_line": 475,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 473,
  "symbol": "Options.managers_map"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":473,"selector":"L473-L475","symbol":"Options.managers_map"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.managers_map](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 475,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 473,
    "symbol": "Options.managers_map"
  },
  "id": "9aa5a2cc-738f-428b-8f63-005ec72948d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.8263110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 473,
        "selector": "L473-L475",
        "symbol": "Options.managers_map"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "8113b96b-b223-4c26-b693-aaf02d8d14ce",
  "subject_name": "django/db/models/options::Options.managers_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def managers_map(self)"
}
```
