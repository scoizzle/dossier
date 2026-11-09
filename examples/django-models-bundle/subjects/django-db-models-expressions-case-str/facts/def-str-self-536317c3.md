# Fact 536317c3

Store id: d5806cfd-2b87-4e91-900c-f767fc486b47

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
- posted_at: `2026-11-09T22:39:41.7082880+00:00`

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
  "id": "d5806cfd-2b87-4e91-900c-f767fc486b47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7082880+00:00"
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
  "subject_id": "82e39784-c555-4c26-9243-e4326d4c1863",
  "subject_name": "django/db/models/expressions::Case.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
