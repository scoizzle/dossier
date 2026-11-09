# Fact 8898b523

Store id: 26449b0d-7e9d-4c6f-b4a2-4c0aa198e0dc

## Text

```text
def desc(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:55.8369680+00:00`

## Data

```json
{
  "end_line": 934,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 933,
  "symbol": "F.desc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":933,"selector":"L933-L934","symbol":"F.desc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.desc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 934,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 933,
    "symbol": "F.desc"
  },
  "id": "26449b0d-7e9d-4c6f-b4a2-4c0aa198e0dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8369680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 933,
        "selector": "L933-L934",
        "symbol": "F.desc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4f02acdf-57eb-4500-8c37-3dd130843172",
  "subject_name": "django/db/models/expressions::F.desc",
  "tags": [
    "entity:method"
  ],
  "text": "def desc(self, **kwargs)"
}
```
