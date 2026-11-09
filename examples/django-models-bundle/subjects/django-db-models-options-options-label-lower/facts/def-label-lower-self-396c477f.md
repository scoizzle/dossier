# Fact 396c477f

Store id: d52039b4-e391-4990-9e12-c2788f5eaafb

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
- posted_at: `2026-11-09T23:44:55.4625080+00:00`

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
  "id": "d52039b4-e391-4990-9e12-c2788f5eaafb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4625080+00:00"
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
  "subject_id": "195f6eaf-b099-41f6-820b-01934ebaa804",
  "subject_name": "django/db/models/options::Options.label_lower",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def label_lower(self)"
}
```
