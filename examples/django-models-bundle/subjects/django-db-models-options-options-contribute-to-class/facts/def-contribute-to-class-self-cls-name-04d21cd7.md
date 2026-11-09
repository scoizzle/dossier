# Fact 04d21cd7

Store id: 50e57e2b-264b-4558-83a9-71ec770c4dab

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
- posted_at: `2026-11-09T23:44:55.4690180+00:00`

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
  "id": "50e57e2b-264b-4558-83a9-71ec770c4dab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.4690180+00:00"
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
  "subject_id": "8d303038-cde7-4837-a4a0-58b56f48e009",
  "subject_name": "django/db/models/options::Options.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name)"
}
```
