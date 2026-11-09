# Fact cbd4f741

Store id: 90b80ac7-0c9f-4a12-8018-3c86512537d7

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:44:49.6844040+00:00`

## Data

```json
{
  "end_line": 2162,
  "entity_kind": "method",
  "parent": "WindowFrame",
  "start_line": 2161,
  "symbol": "WindowFrame.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2161,"selector":"L2161-L2162","symbol":"WindowFrame.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2162,
    "entity_kind": "method",
    "parent": "WindowFrame",
    "start_line": 2161,
    "symbol": "WindowFrame.get_source_expressions"
  },
  "id": "90b80ac7-0c9f-4a12-8018-3c86512537d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6844040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2161,
        "selector": "L2161-L2162",
        "symbol": "WindowFrame.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ecb03d27-c744-459a-9f9d-daca36e7845d",
  "subject_name": "django/db/models/expressions::WindowFrame.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
