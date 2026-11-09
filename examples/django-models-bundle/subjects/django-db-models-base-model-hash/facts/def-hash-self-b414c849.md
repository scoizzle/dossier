# Fact b414c849

Store id: 9ea8170d-731a-471b-902c-57c3af52fb72

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T23:44:48.5277770+00:00`

## Data

```json
{
  "end_line": 651,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 648,
  "symbol": "Model.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":648,"selector":"L648-L651","symbol":"Model.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 651,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 648,
    "symbol": "Model.__hash__"
  },
  "id": "9ea8170d-731a-471b-902c-57c3af52fb72",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5277770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 648,
        "selector": "L648-L651",
        "symbol": "Model.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d3835cc2-92f6-4cf8-9cdf-f0451e0abeb5",
  "subject_name": "django/db/models/base::Model.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
