# Fact 04d21cd7

Store id: c6cd1044-42fe-4810-b7fb-b5571e8c72cc

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
- posted_at: `2026-11-09T22:39:48.7640100+00:00`

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
  "id": "c6cd1044-42fe-4810-b7fb-b5571e8c72cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.7640100+00:00"
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
  "subject_id": "d92efac9-32db-4b6f-9ec3-e4bf949d1a8c",
  "subject_name": "django/db/models/options::Options.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name)"
}
```
