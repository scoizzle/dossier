# Fact 137d41ca

Store id: 6af4c8ae-c51c-4772-a77b-6c974e5abe66

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
- posted_at: `2026-11-09T23:44:48.9067120+00:00`

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
  "id": "6af4c8ae-c51c-4772-a77b-6c974e5abe66",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9067120+00:00"
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
  "subject_id": "7db2be7b-d46d-4225-870f-e5c639e5839d",
  "subject_name": "django/db/models/deletion::Collector",
  "tags": [
    "entity:class"
  ],
  "text": "class Collector"
}
```
