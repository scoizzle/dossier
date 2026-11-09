# Fact 0dc66e68

Store id: 2ccf3e49-9669-42c9-a54a-773e2d8ba158

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T22:39:41.7145890+00:00`

## Data

```json
{
  "end_line": 1759,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1756,
  "symbol": "Case.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1756,"selector":"L1756-L1759","symbol":"Case.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1759,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1756,
    "symbol": "Case.copy"
  },
  "id": "2ccf3e49-9669-42c9-a54a-773e2d8ba158",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7145890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1756,
        "selector": "L1756-L1759",
        "symbol": "Case.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b76a2a0d-e5ef-43e5-9408-716a48de1949",
  "subject_name": "django/db/models/expressions::Case.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
