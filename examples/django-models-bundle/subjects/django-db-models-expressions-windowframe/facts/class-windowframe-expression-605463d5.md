# Fact 605463d5

Store id: 7c560ba4-35f9-4f3a-a80a-4e64ad7c1ab3

## Text

```text
class WindowFrame(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.0125540+00:00`

## Data

```json
{
  "end_line": 2221,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 2137,
  "symbol": "WindowFrame"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2137,"selector":"L2137-L2221","symbol":"WindowFrame"}`

## Items

```json
[
  {
    "text": "Model the frame clause in window expressions. There are two types of frame clauses which are subclasses, however, all processing and validation (by no means intended to be complete) is done here. Thus, providing an end for a frame is optional (the default is UNBOUNDED FOLLOWING, which is the last row in the frame).",
    "locator": {
      "line": 2138
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::WindowFrame](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2221,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 2137,
    "symbol": "WindowFrame"
  },
  "id": "7c560ba4-35f9-4f3a-a80a-4e64ad7c1ab3",
  "items": [
    {
      "locator": {
        "line": 2138
      },
      "text": "Model the frame clause in window expressions. There are two types of frame clauses which are subclasses, however, all processing and validation (by no means intended to be complete) is done here. Thus, providing an end for a frame is optional (the default is UNBOUNDED FOLLOWING, which is the last row in the frame)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0125540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2137,
        "selector": "L2137-L2221",
        "symbol": "WindowFrame"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "66082c23-8f46-4411-8f50-149c011c58fc",
  "subject_name": "django/db/models/expressions::WindowFrame",
  "tags": [
    "entity:class"
  ],
  "text": "class WindowFrame(Expression)"
}
```
