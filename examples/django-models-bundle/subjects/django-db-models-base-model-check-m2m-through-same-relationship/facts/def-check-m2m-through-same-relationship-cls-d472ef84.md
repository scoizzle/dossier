# Fact d472ef84

Store id: 5d8a9f36-3d1c-454d-a71f-6a7e57c057ad

## Text

```text
def _check_m2m_through_same_relationship(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7638120+00:00`

## Data

```json
{
  "end_line": 1989,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1953,
  "symbol": "Model._check_m2m_through_same_relationship"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1953,"selector":"L1953-L1989","symbol":"Model._check_m2m_through_same_relationship"}`

## Items

```json
[
  {
    "text": "Check if no relationship model is used by more than one m2m field.",
    "locator": {
      "line": 1955
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_m2m_through_same_relationship](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1989,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1953,
    "symbol": "Model._check_m2m_through_same_relationship"
  },
  "id": "5d8a9f36-3d1c-454d-a71f-6a7e57c057ad",
  "items": [
    {
      "locator": {
        "line": 1955
      },
      "text": "Check if no relationship model is used by more than one m2m field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7638120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1953,
        "selector": "L1953-L1989",
        "symbol": "Model._check_m2m_through_same_relationship"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "3576b975-5f56-45e2-b0e4-352363a78e34",
  "subject_name": "django/db/models/base::Model._check_m2m_through_same_relationship",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_m2m_through_same_relationship(cls)"
}
```
