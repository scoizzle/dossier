# Fact 396c477f

Store id: aed3176a-17d5-4368-b856-eea023aa4d01

## Text

```text
def label_lower(self)
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
- posted_at: `2026-11-09T22:39:48.7538740+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 176,
  "symbol": "Options.label_lower"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"selector":"L176-L178","symbol":"Options.label_lower"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.label_lower](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 176,
    "symbol": "Options.label_lower"
  },
  "id": "aed3176a-17d5-4368-b856-eea023aa4d01",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7538740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 176,
        "selector": "L176-L178",
        "symbol": "Options.label_lower"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "e4378cd8-06b4-46c1-a8df-50dd4cff2765",
  "subject_name": "django/db/models/options::Options.label_lower",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label_lower(self)"
}
```
