# Fact 410516e7

Store id: 426b11e9-ff36-4f00-846d-42f69787584f

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
- posted_at: `2026-11-09T23:44:48.9161690+00:00`

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
  "id": "426b11e9-ff36-4f00-846d-42f69787584f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9161690+00:00"
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
  "subject_id": "91ad91e6-4831-4f1b-bf14-7a8255676b77",
  "subject_name": "django/db/models/deletion::Collector.instances_with_model",
  "tags": [
    "entity:method"
  ],
  "text": "def instances_with_model(self)"
}
```
