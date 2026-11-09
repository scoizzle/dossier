# Fact 351b9e23

Store id: cdb69069-15dc-441d-88bf-1cbe53be51a3

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
- posted_at: `2026-11-09T23:44:55.5159440+00:00`

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
  "id": "cdb69069-15dc-441d-88bf-1cbe53be51a3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5159440+00:00"
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
  "subject_id": "65489e34-4ff8-4ed1-a995-8c052e7bb600",
  "subject_name": "django/db/models/options::Options.managers_map",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def managers_map(self)"
}
```
