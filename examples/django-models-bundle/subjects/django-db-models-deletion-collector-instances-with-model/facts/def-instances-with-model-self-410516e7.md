# Fact 410516e7

Store id: ff8f88f1-48c3-40cc-8c7f-dfefa422d5bb

## Text

```text
def instances_with_model(self)
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
- posted_at: `2026-11-09T23:31:55.1230510+00:00`

## Data

```json
{
  "end_line": 446,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 443,
  "symbol": "Collector.instances_with_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":443,"selector":"L443-L446","symbol":"Collector.instances_with_model"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.instances_with_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 446,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 443,
    "symbol": "Collector.instances_with_model"
  },
  "id": "ff8f88f1-48c3-40cc-8c7f-dfefa422d5bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1230510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 443,
        "selector": "L443-L446",
        "symbol": "Collector.instances_with_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "aa83fdb8-ea6b-4345-b117-7dce5bf8fce6",
  "subject_name": "django/db/models/deletion::Collector.instances_with_model",
  "tags": [
    "entity:method"
  ],
  "text": "def instances_with_model(self)"
}
```
