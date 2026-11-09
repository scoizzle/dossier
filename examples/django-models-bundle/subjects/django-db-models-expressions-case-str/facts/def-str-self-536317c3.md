# Fact 536317c3

Store id: 531376ee-ad3b-48cd-b948-59f34650b6b8

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:31:55.9591930+00:00`

## Data

```json
{
  "end_line": 1745,
  "entity_kind": "method",
  "parent": "Case",
  "start_line": 1741,
  "symbol": "Case.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1741,"selector":"L1741-L1745","symbol":"Case.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Case.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1745,
    "entity_kind": "method",
    "parent": "Case",
    "start_line": 1741,
    "symbol": "Case.__str__"
  },
  "id": "531376ee-ad3b-48cd-b948-59f34650b6b8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9591930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1741,
        "selector": "L1741-L1745",
        "symbol": "Case.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9b5c80fa-358a-4f60-9a78-409ff7fa1d65",
  "subject_name": "django/db/models/expressions::Case.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
