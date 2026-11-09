# Fact 04d21cd7

Store id: 5f20373c-128b-47a1-88e4-b3d99583bda6

## Text

```text
def contribute_to_class(self, cls, name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.9034340+00:00`

## Data

```json
{
  "end_line": 249,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 185,
  "symbol": "Options.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":185,"selector":"L185-L249","symbol":"Options.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/options::Options.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 249,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 185,
    "symbol": "Options.contribute_to_class"
  },
  "id": "5f20373c-128b-47a1-88e4-b3d99583bda6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.9034340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 185,
        "selector": "L185-L249",
        "symbol": "Options.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "47ce758e-d510-458c-ac1b-24442940eef7",
  "subject_name": "django/db/models/options::Options.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name)"
}
```
