# Fact e77f8531

Store id: 455c46c7-81cc-4c0b-bd81-4c7c304bc7fc

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:44:49.6253070+00:00`

## Data

```json
{
  "end_line": 1748,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1747,
  "symbol": "Case.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1747,"selector":"L1747-L1748","symbol":"Case.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1748,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1747,
    "symbol": "Case.__repr__"
  },
  "id": "455c46c7-81cc-4c0b-bd81-4c7c304bc7fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6253070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1747,
        "selector": "L1747-L1748",
        "symbol": "Case.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f9461afa-e29d-41cc-a946-ed1f77b86a94",
  "subject_name": "django/db/models/expressions::Case.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
