# Fact 0dc66e68

Store id: 9f02605a-b2ee-41a1-85d0-bf9b79c16e83

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
- posted_at: `2026-11-09T23:44:49.6289310+00:00`

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
  "id": "9f02605a-b2ee-41a1-85d0-bf9b79c16e83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6289310+00:00"
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
  "subject_id": "a2f2899f-431f-45ec-82ee-ab6d92a36116",
  "subject_name": "django/db/models/expressions::Case.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
