# Fact 351b9e23

Store id: d596ade5-eb3e-43df-bad7-fb5435bb13b0

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
- posted_at: `2026-11-09T23:32:03.9604150+00:00`

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
  "id": "d596ade5-eb3e-43df-bad7-fb5435bb13b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9604150+00:00"
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
  "subject_id": "787ece27-d87e-4be1-b50b-53cc6a02a43c",
  "subject_name": "django/db/models/options::Options.managers_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def managers_map(self)"
}
```
