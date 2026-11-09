# Fact 137d41ca

Store id: ea58b79b-96b2-4005-855e-2e6039f5dfff

## Text

```text
class Collector
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0935630+00:00`

## Data

```json
{
  "end_line": 552,
  "entity_kind": "class",
  "parent": "deletion",
  "start_line": 117,
  "symbol": "Collector"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L552","symbol":"Collector"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 552,
    "entity_kind": "class",
    "parent": "deletion",
    "start_line": 117,
    "symbol": "Collector"
  },
  "id": "ea58b79b-96b2-4005-855e-2e6039f5dfff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0935630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L552",
        "symbol": "Collector"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "7be0b9ec-c794-4eda-9863-5ac0784b31c2",
  "subject_name": "django/db/models/deletion::Collector",
  "tags": [
    "entity:class"
  ],
  "text": "class Collector"
}
```
